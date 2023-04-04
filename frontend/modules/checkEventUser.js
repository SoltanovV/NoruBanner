const POST_ANALIS_API = "http://localhost:7000/api/Banner/analisis"

const banners = document.querySelectorAll(".banner");

const sawBanners = [];

const info = {
    userIp: "",
    nameBanner: "",
    urlWebsite: "",
    date: "",
    action: 0
};


if (banners){
    onWatchBanner()
    document.addEventListener("scroll", onWatchBanner);
    banners.forEach(banner => banner.addEventListener("click", onClickBanner))

}

function onWatchBanner(e) {
    banners.forEach(banner => {
        const bannerPosBot = banner.getBoundingClientRect().bottom;

        if (bannerPosBot < window.innerHeight && !sawBanners.includes(banner.id))
        {
            let dateLocal = new Date()

            info.nameBanner = document.querySelector(".banner").getAttribute('name')
            info.nameBanner.toString()
            info.urlWebsite = window.location.href
            info.date = dateLocal.toLocaleString()
            info.action = 0


            fetchApi(info);
        }
    })
}

function onClickBanner() {
    document.addEventListener("click", function(e) {

        let dateLocal = new Date()

        info.nameBanner = document.querySelector(".banner").getAttribute('name')
        info.nameBanner.toString()
        info.urlWebsite = window.location.href
        info.date = dateLocal.toLocaleString()
        info.action = 1


        if (e.target.classList.contains("banner")) {
            fetchApi(info)
        }
    });
}

function fetchApi(body){
    fetch(POST_ANALIS_API, {
        method: "POST",
        headers: {"Content-Type": "application/json"},
        body: JSON.stringify(body),
    });
}