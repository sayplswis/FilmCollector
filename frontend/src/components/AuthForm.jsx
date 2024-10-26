import { Button } from '@headlessui/react'
import FloatingTextBox from "./FloatingTextBox";

export default function AuthForm(){
    let input1 = {
        Title: "Имя пользователя:",
        Type: "text"
    }
    let input2 = {
        Title: "Пароль:",
        Type: "password"
    }
    return(
    <div className="bg-black/30 backdrop-blur-sm h-1/2 w-2/3 rounded-xl shadow-xl max-w-[800px]">
        <div className="flex flex-row h-full">
            <img 
            className="w-1/2 h-full rounded-l-xl md:drop-shadow-2xl"
            style={{
                filter: "drop-shadow(0 0 10px rgba(255, 255, 255, 0.8))"
            }}
            src="Madara29.png"></img>
            <div className="p-2 grid items-center w-full">
                <div>
                <FloatingTextBox label={input1}/>
                <FloatingTextBox label={input2}/>
                    <div className='m-4 flex justify-end'>
                        <Button className="inline-flex items-center justify-center gap-2 rounded-md w-2/5
                         bg-gray-700 py-1.5 px-3 text-sm/6 font-semibold text-white shadow-inner
                         shadow-white/10 focus:outline-none data-[hover]:bg-gray-600
                         data-[open]:bg-gray-700 data-[focus]:outline-1 data-[focus]:outline-white"> Войти
                        </Button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    )
}