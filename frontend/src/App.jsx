import * as React from 'react'
import Filter from './components/Filter'
import TopMenu from './components/TopMenu'

function App() {
  return (
 <div className='bg-gradient-to-r from-[#778beb] to-[#546de5] h-screen w-screen overflow-hidden'>
    <div className=''>
      <TopMenu />
      <Filter />
    </div>
</div> 
  )
}

export default App



  {/* <div className="grid grid-cols-[repeat(auto-fit,minmax(300px,1fr))] gap-4 mx-5">
                {films.map(film => (
                    <MovieCard key={film.id} film={film} />
                ))}
            </div> */}