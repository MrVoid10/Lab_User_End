function loadUsers() {
	const users = JSON.parse(localStorage.getItem("users")) || [];
	const userList = document.getElementById("users");
	userList.innerHTML = "";
	users.forEach(user => {
		const li = document.createElement("li");
		li.textContent = `Nume: ${user.firstName} ${user.lastName}, Email: ${user.email}, Data Nașterii: ${user.birthDate}`;
		userList.appendChild(li);
	});
}

function saveUser(user) {
	const users = JSON.parse(localStorage.getItem("users")) || [];
	users.push(user);
	localStorage.setItem("users", JSON.stringify(users));
	loadUsers();
}

function checkAge(birthDate) {
	const birthYear = new Date(birthDate).getFullYear();
	const currentYear = new Date().getFullYear();
	return currentYear - birthYear >= 18;
}

function checkNameFormat(firstName, lastName) {
	let errorMessage = "";
	if (firstName.charAt(0) !== firstName.charAt(0).toUpperCase()) {
		errorMessage += "Numele trebuie să înceapă cu literă mare. ";
	}
	if (lastName.charAt(0) !== lastName.charAt(0).toUpperCase()) {
		errorMessage += "Prenumele trebuie să înceapă cu literă mare. ";
	}
	return errorMessage;
}

document.getElementById("userForm").addEventListener("submit", function(event) {
	event.preventDefault();

	const firstName = document.getElementById("firstName").value;
	const lastName = document.getElementById("lastName").value;
	const email = document.getElementById("email").value;
	const birthDate = document.getElementById("birthDate").value;

	if (!checkAge(birthDate)) {
		document.getElementById("error-message").textContent = "Nu ai vârsta legală (minim 18 ani).";
		return;
	} else {
		document.getElementById("error-message").textContent = ""; 
	}


	const nameError = checkNameFormat(firstName, lastName);
	if (nameError) {
		document.getElementById("warning-message").textContent = nameError;
	} else {
		document.getElementById("warning-message").textContent = "";
	}

	const user = {
		firstName: firstName,
		lastName: lastName,
		email: email,
		birthDate: birthDate
	};

	saveUser(user);
	this.reset();
});

loadUsers();