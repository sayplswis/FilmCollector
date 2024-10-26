import { Button } from '@headlessui/react'

export default function MovieCard(){
    return(
        <div className='flex flex-col items-center p-2 shadow-xl shadow-zinc-800/50 rounded-lg m-2 bg-gray-900/75 backdrop-blur-md max-h-[60vh]'>
            <p className='text-center pb-2 font-bold text-white/85'>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
            <p className='overflow-y-scroll scrollbar-hide max-h-[30vh] mb-2'>
                <img 
                        className="aspect-square w-40 rounded-3xl float-left mr-4 mb-2" 
                        src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiNwAnzPHgL_5_IiNhZnLB0VG-tVETpdPJXw&s" 
                        alt="naruto" />
                 <span className="text-justify italic overflow-auto text-white/50 overflow-y-scroll scrollbar-hide max-h-[30vh]">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                </span>
            </p>
            <div className='w-full flex justify-between px-4'>
                <Button className="myButton bg-red-300 text-red-950 hover:bg-red-400">Удалить</Button>
                <Button className="myButton bg-green-300 text-green-950 hover:bg-green-400">Просмотрен</Button>
            </div>
        </div>
    );
}