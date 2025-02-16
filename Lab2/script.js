function verificaVârstă() {
  const dataNastere = document.getElementById("dataNastere").value;
  const mesajElement = document.getElementById("mesaj");

  // Verificăm dacă utilizatorul a introdus o dată
  if (!dataNastere) {
      mesajElement.textContent = "Te rog să selectezi o dată de naștere.";
      mesajElement.style.color = "orange";
      return;
  }

  // Creăm un obiect Date din data introdusă
  const dataNastereDate = new Date(dataNastere);
  const dataCurenta = new Date();

  // Calculăm vârsta utilizatorului
  let varsta = dataCurenta.getFullYear() - dataNastereDate.getFullYear();
  const lunaCurenta = dataCurenta.getMonth();
  const lunaNastere = dataNastereDate.getMonth();

  // Ajustăm vârsta dacă nu a trecut încă ziua de naștere în acest an
  if (lunaCurenta < lunaNastere || (lunaCurenta === lunaNastere && dataCurenta.getDate() < dataNastereDate.getDate())) {
      varsta--;
  }

  // Verificăm vârsta și afișăm mesajul corespunzător
  if (varsta >= 18) {
      mesajElement.textContent = "Ești major. Ai acces la această secțiune!";
      mesajElement.style.color = "green";
  } else if (varsta > 0) {
      mesajElement.textContent = "Ești minor. Accesul este restricționat.";
      mesajElement.style.color = "red";
  } else {
      mesajElement.textContent = "Vârstă invalidă.";
      mesajElement.style.color = "orange";
  }
}
