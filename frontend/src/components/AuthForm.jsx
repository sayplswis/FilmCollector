import FloatingTextBox from "./FloatingTextBox";

export default function AuthForm(){
    return(
    <div className="bg-white/30 backdrop-blur-sm h-2/3 w-2/3">
        <div className="flex flex-row h-full">
            <img 
            className="w-1/3 h-full"
            src="https://cdn.lifehacker.ru/wp-content/uploads/2023/06/aOYWGNKMbrae3V0bAQQfA_1686221994-e1686222020241-630x315.jpg"></img>
            <div className="p-20"> 
                <FloatingTextBox label="Имя пользователя"/>
                <FloatingTextBox label="Пароль"/>
                <button className="bg-red-300 rounded-md w-24 p-1 m-3 hover:bg-red-900">Войти</button>
            </div>
        </div>
    </div>
    )
}