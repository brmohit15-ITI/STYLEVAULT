function toggleMenu() {
    const nav = document.querySelector(".navbar nav");

    if (nav.style.display === "flex") {
        nav.style.display = "none";
    } else {
        nav.style.display = "flex";
        nav.style.flexDirection = "column";
        nav.style.position = "absolute";
        nav.style.top = "76px";
        nav.style.right = "5%";
        nav.style.background = "white";
        nav.style.padding = "20px";
        nav.style.width = "220px";
        nav.style.boxShadow = "0 10px 30px rgba(0,0,0,.1)";
    }
}