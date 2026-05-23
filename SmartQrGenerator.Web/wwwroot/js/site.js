(function () {
    const savedTheme = localStorage.getItem("theme") || "light";
    document.documentElement.setAttribute("data-theme", savedTheme);
})();

function toggleTheme() {

    const html = document.documentElement;
    const btn = document.getElementById("themeIcon");

    const current = html.getAttribute("data-theme");

    const next =current === "dark" ? "light": "dark";

    html.setAttribute("data-theme", next);
    localStorage.setItem("theme", next);

    btn.className =next === "dark" ? "fa-solid fa-sun" : "fa-solid fa-moon";
}

function copyLink() {
    const urlElement = document.getElementById("qrUrl");

    if (!urlElement) {
        alert("No QR link found.");
        return;
    }

    const link = urlElement.innerText.trim();

    navigator.clipboard.writeText(link)
        .then(() => alert("Link copied successfully!"))
        .catch(() => alert("Unable to copy link."));
}

async function shareQr() {
    const urlElement = document.getElementById("qrUrl");

    if (!urlElement) {
        alert("No QR link found.");
        return;
    }

    const link = urlElement.innerText.trim();

    if (navigator.share) {
        await navigator.share({
            title: "Smart QR Code",
            text: "Open this QR code link",
            url: link
        });
    } else {
        alert("Share option is not supported in this browser.");
    }
}