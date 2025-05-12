window.onload = function() {
    openMenu()
    closeMenu()
}

function changeClass(element, className, time) {
    setTimeout(() => {
        element.classList.toggle(className)
    }, time)
}

function openMenu() {
    const navMenu =  document.querySelector('.js-nav__menu');
    const toggleButton = document.querySelector('.js-nav__toggle');
    if(toggleButton && navMenu) {
        toggleButton.addEventListener('click', function(event) {
            navMenu.classList.add('is-open')
        })
    }
}

function  closeMenu() {
    
    // Button close
    const navMenu = document.querySelector('.js-nav__menu')
    const closeButton = document.querySelector('.js-nav__close');
    if(closeButton && navMenu) {
        closeButton.addEventListener('click', function(event) {
            navMenu.classList.remove('is-open')
        })
    }
    
    // Esc close
    if(navMenu) {
        document.addEventListener('keydown', function(event) {
            if (event.key === 'Escape') {
                navMenu.classList.remove('is-open')
            }
        });
    }
}