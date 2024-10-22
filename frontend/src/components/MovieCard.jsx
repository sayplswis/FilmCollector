
export default function MovieCard({ film }){
    return(
        <div className='flex flex-col items-center p-2 shadow-xl shadow-zinc-800/50 rounded-lg m-2 bg-gradient-to-r from-sky-200 to-zinc-400'>
            <div className='text-center pb-2 font-bold'>{film.title}</div>
            <img class="aspect-square w-40 rounded-3xl mx-auto" src={film.image} alt={film.title}/>
            <div className='text-justify p-4 italic'>{film.description}</div>
            <div className='w-full flex justify-between px-4'>
                <button className='w-1/3 m-1 p-1 rounded-3xl bg-slate-400'>Удалить</button>
                <button className='w-1/3 m-1 p-1 rounded-3xl bg-gray-400'>Добавить</button>
                <button className='w-1/3 m-1 p-1 rounded-3xl bg-zinc-700'>Закончить</button>
            </div>
        </div>
    );
}