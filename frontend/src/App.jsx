import * as React from 'react'
import Filter from './components/Filter'
import TopMenu from './components/TopMenu'
import MovieCard from './components/MovieCard'
import AuthForm from './components/AuthForm'

function App() {
  return (
 <div
 style={{ backgroundImage: `url('/back.jpg')` }} 
 className='bg-cover bg-center h-screen w-screen overflow-hidden flex flex-col gap-4'>
    <div>
      <TopMenu />
    </div>
    <div className='flex-grow flex items-center justify-center'>
        {/* <AuthForm></AuthForm> */}
        <div className='bg-black/30 backdrop-blur-md rounded-3xl w-full max-h-[90vh] mx-2 mt-4 mb-8'>
                            <Filter></Filter>
                            <div className='w-full max-h-[84vh] sm:max-h-[70vh] md:max-h-[78vh] xl:max-h-[84vh] grid grid-cols-[repeat(auto-fit,minmax(300px,1fr))] gap-4 overflow-y-scroll scrollbar-hide p-[10px]'>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            <MovieCard></MovieCard>
                            </div>
                            

        </div>
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