import { Field, Input, Label } from '@headlessui/react'
import clsx from 'clsx'

export default function FloatingTextBox({ label }){
    return(
        <div className="w-full px-4 m-1">
        <Field>
          <Label className="text-l font-bold text-white/80">{label.Title}</Label>
          {/* <Description className="text-sm/6 text-white/50">Use your real name so people will recognize you.</Description> */}
          <Input
          type={label.Type}
            className={clsx(
              'mt-1 block w-full rounded-lg border-none bg-white/5 py-1.5 px-3 text-sm/6 text-white shadow-sm shadow-yellow-200/50',
              'focus:outline-none data-[focus]:outline-2 data-[focus]:-outline-offset-2 data-[focus]:outline-white/25'
            )}
          />
        </Field>
      </div>
    )
}


