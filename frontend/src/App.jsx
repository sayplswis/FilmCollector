import * as React from 'react'
import SideMenu from './components/SideMenu'
import MovieCard from './components/MovieCard'

function App() {
  return (
 <div className='flex bg-gradient-to-r from-gray-800 to-stone-600'>
  {/* <SideMenu/>  */}
  <div class="grid grid-cols-[repeat(auto-fit,minmax(300px,1fr))] gap-4">
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
    <MovieCard/>
  </div>
</div> 
  )
}

export default App
