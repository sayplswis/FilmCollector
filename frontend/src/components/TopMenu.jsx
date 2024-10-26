import { Button } from '@headlessui/react'

export default function TopMenu(){
    return(
        <div className='w-full h-[50px] bg-black/30 backdrop-blur-sm'>
            <div className='flex flex-row-reverse'>
                <Button className="bg-transparent max-w-[80px] m-1 text-lg p-1.5 font-semibold text-white/50 focus:outline-none data-[hover]:bg-gray-100/10 rounded-lg">Выход</Button>
                <span className="h-[50px] w-[1px] bg-white/40 mx-1"></span>
                <Button className="bg-transparent max-w-[80px] m-1 text-lg p-1.5 font-semibold text-white/50 focus:outline-none data-[hover]:bg-gray-100/10 rounded-lg">Пока</Button>
                <span className="h-[50px] w-[1px] bg-white/40 mx-1"></span>
                <Button className="bg-transparent max-w-[80px] m-1 text-lg p-1.5 font-semibold text-white/50 focus:outline-none data-[hover]:bg-gray-100/10 rounded-lg">GG WP</Button>
            </div>
        </div>
    )
}