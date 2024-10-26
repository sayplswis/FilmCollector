import { Button } from "@headlessui/react";
import NewListBox from "./NewListBox.jsx";


const dateFilter = [
    { id: 1, name: 'Сначала старые' },
    { id: 2, name: 'Сначала новые' }
  ]
  const statusFilter = [
    { id: 1, name: 'Ожидающие' },
    { id: 2, name: 'Просмотренные' },
    { id: 3, name: 'Все' }
  ]



export default function Filter(){
    return(
        <div className='h-[150px] sm:h-[150px] md:h-[100px] lg:h-[100px] xl:h-[50px] bg-gray-900/60 w-full rounded-t-3xl flex flex-col sm:flex-row items-center px-[20px]'>
            <div className="flex flex-row flex-wrap mb-auto">
                <div className="flex flex-row mt-[2px]">
                    <p className="font-bold text-white/80 pt-[12px] min-w-[192px]">Сортировка по дате:</p>
                    <NewListBox filterValues={dateFilter} />
                </div>
                <div className="flex flex-row ml-[2px] mt-[2px] mr-[2px]">
                    <p className="font-bold text-white/80  pt-[12px] mr-[2px] min-w-[192px]">Сортировка по статусу:</p>
                    <NewListBox filterValues={statusFilter} />
                </div>
            </div>
            <div className="flex-grow mt-2 sm:mt-0 sm:ml-auto flex">
                <Button className="myButton py-0 px-0 h-full w-full bg-green-300 text-green-950 font-extrabold hover:bg-green-400 flex-grow">Добавить</Button>
            </div>
        </div>
    )
}