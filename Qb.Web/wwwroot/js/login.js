window.addEventListener('load', function(event) {
    handleLogin();
})

/**
* This function handles the login logic.
* @param {SubmitEvent} e - The submit event.
* @return {VoidFunction} - Dont rerurn any value.
* */
function handleLogin() {
    document.getElementById("login").addEventListener("submit", async function(e) {
        e.preventDefault(); 
        
        // Form data
        const loginButton = document.getElementById("login-button");
        const formData = new FormData(this);
        const loginLoader = document.getElementById("login-loader");
        const loginError = document.getElementById("login-error");

        // Clear error message
        loginError.classList.remove('is-visible');
        
        // Handle the button style while the login 
        // is in process.
        if(loginButton){
            loginButton.classList.add('is-loading');
        }
        
        if(loginLoader) {
            loginLoader.classList.add('is-visible');
        }

        try {
            const response = await fetch("/Login/Auth", {
                method: "POST",
                body: formData
            });

            if (!response.ok) {
                throw new Error("Credenciais inválidas ou erro na autenticação");
            }

            const data = await response.json();
            console.log("Resposta do servidor:", data);

            // Redireciona para a página inicial se o login for bem-sucedido
            window.location.href = '/';

        } catch (error) {
            console.error("Erro:", error);
            loginError.classList.add('is-visible');
        } finally {
            loginLoader.classList.remove('is-visible');
            loginButton.classList.remove('is-loading');
        }
        
        
    });
}
