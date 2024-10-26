import { Listbox, ListboxButton, ListboxOption, ListboxOptions } from '@headlessui/react'
import clsx from 'clsx'
import { useState } from 'react'


export default function NewListBox({ filterValues }){
  const [selected, setSelected] = useState(filterValues[0])
    return(
      <div className="w-[250px] my-[6px] mx-[2px] min-w-[206px]">
      <Listbox value={selected} onChange={setSelected}>
        <ListboxButton className={clsx(
            'relative block w-full rounded-lg bg-white/5 py-1.5 pr-8 pl-3 text-left text-sm/6 text-white',
            'focus:outline-none data-[focus]:outline-2 data-[focus]:-outline-offset-2 data-[focus]:outline-white/25')}>
          {selected.name}
        </ListboxButton>
        <ListboxOptions
          anchor="bottom"
          transition
          className={clsx(
            'w-[var(--button-width)] rounded-xl border border-white/5 bg-gray-900/95 p-1 [--anchor-gap:var(--spacing-1)] focus:outline-none',
            'transition duration-100 ease-in data-[leave]:data-[closed]:opacity-0'
          )}
        >
          {filterValues.map((filter) => (
            <ListboxOption
              key={filter.name}
              value={filter}
              className="group flex cursor-default items-center gap-2 rounded-lg py-1.5 px-3 select-none data-[focus]:bg-white/10">
              <div className="text-sm/6 text-white">{filter.name}</div>
            </ListboxOption>
          ))}
        </ListboxOptions>
      </Listbox>
    </div>
    )
}