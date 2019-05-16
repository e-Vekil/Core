// MAIN VIDEO WIDTH
var w = $(window).width();
//$('#mainVideo').css('width', w);

// ON SCROLL NAVBAR FIXED
var navBarWrapper = document.querySelector(".nav-bar-wrapper");
var navBarHeader = document.querySelector(".nav-bar-wrapper .header");
var serachMenu = document.querySelector("#search-menu");
window.addEventListener("scroll", function () {

    if (document.body.scrollTop > 20 || this.document.documentElement.scrollTop > 20) {
        navBarWrapper.classList.add("scroll-design");
        navBarHeader.classList.add("scroll-design");
        serachMenu.classList.add("scroll-design");

    }
    else {
        navBarWrapper.classList.remove("scroll-design");
        navBarHeader.classList.remove("scroll-design");
        serachMenu.classList.remove("scroll-design");
    }

})
//SIDE BAR OPEN-CLOSE
var sideBar = document.querySelector(".side-bar")
var closeIcon = document.querySelector(".close-icon");
var iconBurger = document.querySelector(".icon-burger-wrapper")

iconBurger.addEventListener("click", function () {
    sideBar.classList.add("open");
})
closeIcon.addEventListener("click", function () {
    sideBar.classList.remove("open");
})


                                                                //Close Navbar On Windows Click

$(document).ready(function () {
    $(document).click(function (event) {
        var clickover = $(event.target);
        var clicked = event.target.tagName.toUpperCase();
        var _opened = $(".side-bar").hasClass("side-bar open");
        //console.log(clickover);
        if (_opened === true && !clickover.hasClass("side-bar-content") && !clickover.hasClass("icon-burger-wrapper") && !clickover.hasClass("icon-burger") && !clickover.hasClass("close-icon") && clicked != 'LI' && clicked != 'UL') {
            $(".side-bar").removeClass("open");
            //console.log("Hello");
        }
    });
});

    
                                                                 //Scroll Transition


//function init() {
//    new SmoothScroll(document, 220, 42)
//}

//function SmoothScroll(target, speed, smooth) {
//    if (target == document)
//        target = (document.documentElement || document.body.parentNode || document.body) // cross browser support for document scrolling
//    var moving = false
//    var pos = target.scrollTop
//    target.addEventListener('mousewheel', scrolled, false)
//    target.addEventListener('DOMMouseScroll', scrolled, false)

//    function scrolled(e) {
//        e.preventDefault(); // disable default scrolling
//        var delta = e.delta || e.wheelDelta;
//        if (delta === undefined) {
//            //we are on firefox
//            delta = -e.detail;
//        }
//        delta = Math.max(-1, Math.min(1, delta)) // cap the delta to [-1,1] for cross browser consistency

//        pos += -delta * speed
//        pos = Math.max(0, Math.min(pos, target.scrollHeight - target.clientHeight)) // limit scrolling
//        //console.log(5);

//        if (!moving) {
//            update();
//            //console.log(6);
//        }
//    }

//    function update() {
//        moving = true
//        var delta = (pos - target.scrollTop) / smooth
//        target.scrollTop += delta
//        if (Math.abs(delta) > 2) {
//            //console.log("delta value: " + Math.abs(delta));
//            requestFrame(update);
//            //console.log(1);
//        }
//        else {
//            //console.log("delta value: " + Math.abs(delta));
//            moving = false;
//            //console.log(2);
//        }
//    }

//    var requestFrame = function () { // requestAnimationFrame cross browser
//        return (
//            window.requestAnimationFrame ||
//            window.webkitRequestAnimationFrame ||
//            window.mozRequestAnimationFrame ||
//            window.oRequestAnimationFrame ||
//            window.msRequestAnimationFrame ||
//            function (func) {
//                window.setTimeout(func, 1000 / 50);
//            }
//        );
//    }()
//}


                                                //ScrollDown ScrollUp

    $(window).scroll(function () {
        if (document.body.scrollTop > 40 || document.documentElement.scrollTop > 40) {
            $('#navHelperADown').addClass('hidden');
            $('#navHelperAUp').removeClass('hidden');
        } else {
            $('#navHelperAUp').addClass('hidden');
            $('#navHelperADown').removeClass('hidden');
        }

    });


$(document).ready(function () {
    $("#navHelperADown").on('click', function (event) {
        if (this.hash !== "") {
            event.preventDefault();
            var hash = this.hash;
            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 800, function () {
                window.location.hash = hash;
            });
        }
    });
});

$(document).ready(function () {
    $("#navHelperAUp").on('click', function (event) {
        if (this.hash !== "") {
            event.preventDefault();
            var hash = this.hash;
            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 800, function () {
                window.location.hash = hash;
            });
        }
    });
});

                                                //ScrollRight

$(document).ready(function () {
    $("li:has(a.slider)").on('click', function (event) {
        if (this.firstElementChild.hash !== "") {
            event.preventDefault();
            var hash = this.firstElementChild.hash;
            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 800, function () {
                window.location.hash = hash;
            });
        }
    });
});

//ISOTOP DYNAMIC
$(document).ready(function () {
    $(".isotop a").on('click', function (event) {
        if (this.hash !== "") {
            event.preventDefault();
            var hash = this.hash;
            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 800, function () {
                window.location.hash = hash;
            });
        }
    });
});



                                        //Scroll Left(NAVBAR)

$(document).ready(function () {
    $(".side-bar-content li").on('click', function (event) {
        var sideBar = document.querySelector(".side-bar")
        if (this.firstElementChild.hash !== "") {
            event.preventDefault();
            sideBar.classList.remove("open");
            var hash = this.firstElementChild.hash;
            $(hash).css("display", "block");
            if ($(window).width() > 650) {
                $('html, body').animate({
                    scrollTop: $(hash).offset().top
                }, 800, function () {
                    window.location.hash = hash;
                });
            } else {
                $('html, body').animate({
                    scrollTop: $(hash).offset().top-150
                }, 800, function () {
                    //window.location.hash = hash;
                    history.replaceState('', '/', hash);
                });
            }
        }
    });
});

// Slider Click
var icons = document.querySelectorAll(".slider-wrapper li");
var activeIcon = document.querySelector(".slider-wrapper li .slider.active");
for (var icon of icons) {
    icon.addEventListener("click", function () {
        activeIcon.classList.remove("active");
        this.firstElementChild.classList.add("active");
        activeIcon = this.firstElementChild;
    })
}

//Dynamic ScrollRight

//$(window).scroll(function () {
//    var icons = [].slice.call(document.querySelectorAll(".sect"), 0).reverse();
//    var activeIcon = document.querySelector(".slider-wrapper li .slider.active");
//    for (var icon of icons) {
//        if (icon.offsetTop - 50 < $(window).scrollTop()) {
//            if (icon.id != activeIcon.attributes[2].value) {
//                activeIcon.classList.remove("active");
//                document.querySelector(".slider." + icon.id).classList.add("active");
//                history.replaceState('', 'https://localhost:44343/#main2', '#' + icon.id);  
//            }
//            break;
//        }
//    }
//});
// Change Slider Color

window.addEventListener("scroll", function () {
    if (document.documentElement.scrollTop >= window.innerHeight - 400) {
        for (var icon of icons) {
            icon.firstElementChild.classList.add("change");
        }
    }
    else {
        for (var icon of icons) {
            icon.firstElementChild.classList.remove("change");
        }
    }
})

$(document).ready(function () {
    $(".category-name").click(function () {
        $(this).next().slideToggle(600);
        //$(".category-icon i").toggleClass("rotate")
    })
})
    

                                        //Categories Header Parallax Effect

var i = 0;
var count = 0;
var previcon;
$(window).scroll(function () {
    var icons = [].slice.call(document.querySelectorAll(".sect"), 0).reverse(); 
    for (var icon of icons) {
        if (icon.offsetTop - 650 < $(window).scrollTop()) {
           
            if (icon != previcon) {
                if (count > $(window).scrollTop()) {
                    i = -50;
                } else {
                    i = -14;
                }
            }
            if (i == -50) {
                i++;
            } else if (i == 50) {
                i--;
            }

            if (count < $(window).scrollTop()) {
                if (Math.abs(i) < 50) {
                    i--;
                }
            } else {
                if (Math.abs(i) < 50) {
                    i++;
                }
            }

            $("#" + icon.id + " h1.category-title").css("transform", "translateY(" + i + "px)");
            count = $(window).scrollTop();
            previcon = icon;
            break;
        }
    }
});


//REGISTIRATION DYNAMIC FADE
var forms = document.querySelectorAll(".form-wrapper > div");
var buttons = document.querySelectorAll(".registration-wrapper .buttons a");

for (var button of buttons) {
    button.addEventListener("click", function () {
        if (this.nextElementSibling) {
            this.nextElementSibling.classList.add("active");
            this.classList.remove("active");
        }
        else {
            this.previousElementSibling.classList.add("active");
            this.classList.remove("active");
        }
       
        var dataId = this.getAttribute("data-id");
        for (var form of forms) {
            form.classList.remove("active");
            if (form.getAttribute("data-name") == dataId) {
                form.classList.add("active");
            }
        }

    })
}

//BASKET SIDE BAR
var basket = document.querySelector(".basket-wrapper");
var sideBarProduct = document.querySelector(".side-bar-product-wrapper");
var bodywrapper = document.querySelector(".body-wrapper");
basket.addEventListener("click", function () {
    bodywrapper.style.opacity = "1";
    bodywrapper.style.visibility = "visible";
    sideBarProduct.classList.add("open");
})

var sideBarProductCloseIcon = document.querySelector(".side-bar-product .close-icon-product");
sideBarProductCloseIcon.addEventListener("click", function () {
    bodywrapper.style.opacity = "0";
    bodywrapper.style.visibility = "hidden";
    sideBarProduct.classList.remove("open");
})


    
                                         //Close BASKET On Windows Click

$(document).ready(function () {
    $(document).click(function (event) {
        var clickover = $(event.target);
        var _opened = $(".side-bar-product-wrapper").hasClass("side-bar-product-wrapper open");
        if (_opened === true && clickover.hasClass("side-bar-product-wrapper")) {
            bodywrapper.style.opacity = "0";
            bodywrapper.style.visibility = "hidden";
            $(".side-bar-product-wrapper").removeClass("open");
        }
    });
});


//Document Description Reviews and Descriptions

var descriptionAndReview = document.querySelectorAll(".document-desc-features .features");
var changeButtons = document.querySelectorAll(".document-desc-features span");

for (var button of changeButtons) {
    button.addEventListener("click", function () {
        for (var button of changeButtons) {
            button.classList.remove("active");
        }
        this.classList.add("active");
        var dataId = this.getAttribute("data-id");
        console.log(dataId)
        for (var div of descriptionAndReview) {
            div.classList.remove("active");
            if (div.getAttribute("data-name") == dataId) {
                div.classList.add("active");
            }
        }
    })
}

//SEARCH
var iconsOfSearch = document.querySelectorAll(".search-wrapper i");
var searchBox = document.querySelector(".search-wrapper .search");

for (var icon of iconsOfSearch) {
    icon.addEventListener("click", function () {
        if (this.nextElementSibling && this.nextElementSibling.classList.contains("searchIcon") && this.classList.contains("in")) {
            this.classList.remove("in");
            this.classList.add("out");
            this.nextElementSibling.classList.add("in");
            this.nextElementSibling.classList.remove("out");
        }
        else {
            this.classList.remove("in");
            this.classList.add("out");
            this.previousElementSibling.classList.add("in");
            this.previousElementSibling.classList.remove("out");
        }

        if (this.classList.contains("open-search-box")) {
            this.nextElementSibling.nextElementSibling.classList.add("active");
        }
        else {
            this.nextElementSibling.classList.remove("active");
        }
    })
}


//ACCOUNT PAGE NAV CLICK

var navlist = document.querySelectorAll(".account-nav-content li");
for (var nl of navlist) {
    nl.addEventListener("click", function () {
        var navlistactive = document.querySelector(".account-nav-content li.active");
        navlistactive.classList.remove("active");
        this.classList.add("active");
        navlistactive = this.firstElementChild;
    })
}


$(document).ready(function () {
    $(".rg-button").click(function () {
        $(".confirm").show();
    })

   
    //About on click dynamic scroll with transition
    $(".about-nav a").on('click', function (event) {
        if (this.hash !== "") {
            event.preventDefault();
            var hash = this.hash;
            $('html, body').animate({
                scrollTop: $(hash).offset().top-100
            }, 800, function () {
            });
        }
    });

    var aboutNavListItems = document.querySelectorAll(".about-nav a");
    var aboutNavSpans = document.querySelectorAll(".about-nav a span")

    for (var item of aboutNavListItems) {
        item.addEventListener("click", function (e) {
            for (var span of aboutNavSpans) {
                span.classList.remove("active");
            }
            this.firstElementChild.classList.add("active");
        })
    }



    //About dynamic scroll left


    $(window).scroll(function () {
        var fromtop = document.getElementById("About").offsetTop - $(window).scrollTop();
        var aboutUss = [].slice.call(document.querySelectorAll(".about-us"), 0);
        var activeIcon = document.querySelector(".about-nav-item.active");
        for (var aboutUs of aboutUss) {
                if (fromtop + aboutUs.offsetTop > -500) {
                    if (aboutUs.id != activeIcon.attributes[2].value) {
                        activeIcon.classList.remove("active");
                        document.querySelector(".about-nav-item" + "." + aboutUs.id).classList.add("active");
                    }
                    break;
                } 
            }
    });



    //About accordion
    $(".accordion").click(function () {
        var dataId = $(this).attr("data-id");
        var elements = document.querySelectorAll(".about-us");
        for (var element of elements) {
            var dataName = element.getAttribute("data-name");
            if (dataId == dataName) {
                if (element.classList.contains("active")) {
                    element.classList.remove("active");
                    $(this).children("h3").removeClass("active");
                    $(this).children("i").removeClass("active");
                }
                else {
                    $(this).children("h3").addClass("active");
                    element.classList.add("active");
                    $(this).children("i").addClass("active");
                }
            }
        }

    })



    ////Search

    $("#search").keyup(function () {
        if ($('#search-menu')[0].hasChildNodes()){
            $("#search-menu").removeClass("active");
        }

       
        $("#search-menu").empty();
        var word = $(this).val();
        $.ajax({
            url: "/Home/Search/" + word,
            type:"post",
            success: function (response) {
                if (response.status == 200) {
                    for (var i = 0; i < response.data.length; i++) {
                        var listItem = `<li><a href="/Home/DocumentDesc/`+response.data[i].id+`">` + response.data[i].name + `</a></li>`;
                        $("#search-menu").append(listItem);
                        $("#search-menu").addClass("active");
                    }
                }
            }
        })
    })


    $(".search-wrapper i").click(function () {
        if (!$("#search").hasClass("active")) {
            $("#search-menu").removeClass("active");
            $("#search-menu").empty();
            $("#search").empty();
        }
    })
})