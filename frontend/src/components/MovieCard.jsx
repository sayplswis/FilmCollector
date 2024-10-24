
export default function MovieCard(){
    return(
        <div className='flex flex-col items-center p-2 shadow-xl shadow-zinc-800/50 rounded-lg m-2 bg-gradient-to-r from-sky-200 to-zinc-400'>
            <div className='text-center pb-2 font-bold'>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</div>
            <img className="aspect-square w-40 rounded-3xl mx-auto" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiNwAnzPHgL_5_IiNhZnLB0VG-tVETpdPJXw&s" alt="naruto"/>
            <div className='text-justify p-4 italic overflow-auto'>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</div>
            <div className='w-full flex justify-between px-4'>
                <button className='w-1/3 m-1 p-1 rounded-3xl bg-slate-400'>Удалить</button>
                <button className='w-1/3 m-1 p-1 rounded-3xl bg-gray-400'>Добавить</button>
                <button className='w-1/3 m-1 p-1 rounded-3xl bg-zinc-700'>Закончить</button>
            </div>
        </div>
    );
}