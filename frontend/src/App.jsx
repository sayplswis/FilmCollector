import * as React from 'react'
import Filter from './components/Filter'
import TopMenu from './components/TopMenu'
import MovieCard from './components/MovieCard'
import AuthForm from './components/AuthForm'

function App() {
  return (
 <div
 style={{ backgroundImage: `url('/background.jpeg')` }} 
 className='bg-cover bg-center h-screen w-screen overflow-hidden flex flex-col'>
    <div>
      <TopMenu />
      <Filter />
    </div>
      <div className='flex-grow flex items-center justify-center'>
        <AuthForm></AuthForm>
        {/* <div className='w-[30rem] h-[30rem] bg-red-500 blur-md'>
          <input placeholder='Helo'></input>
        </div> */}
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