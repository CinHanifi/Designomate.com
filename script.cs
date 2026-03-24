document.addEventListener("DOMContentLoaded", function() {
  console.log("Designomate sitesi başarıyla yüklendi!");

  // Menü linklerine tıklanınca console log
  document.querySelectorAll("nav a").forEach(link => {
    link.addEventListener("click", () => {
      console.log(link.textContent + " bölümüne gidiliyor...");
    });
  });
});