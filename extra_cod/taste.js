// Ascultă evenimentul de apăsare a tastelor
document.addEventListener("keydown", function(event) {
    // Verifică dacă tasta apăsată este 'Q' sau 'q'
    if (event.key === "Q" || event.key === "q") {
        // Redirecționează utilizatorul către pagina "main.html"
        window.location.href = "../main.html";
    }
});
