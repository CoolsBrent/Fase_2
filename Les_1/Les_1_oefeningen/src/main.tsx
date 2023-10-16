import ReactDOM from 'react-dom/client'
import {StrictMode} from 'react'
import Exercise from './Exercise.tsx'
import ExerciseOne from './ExerciseOne/ExerciseOne.tsx'
import ExerciseTwo from './ExerciseTwo/ExerciseTwo.tsx'
import ExerciseThree from './ExerciseThree/ExerciseThree.tsx'
import ExerciseFour from './ExerciseFour/ExerciseFour.tsx'
import ExerciseFive from './ExerciseFive/ExerciseFive.tsx'


import './assets/main.css'
import ExerciseSix from './ExerciseSix/ExerciseSix.tsx'

const root = ReactDOM.createRoot(
    document.getElementById('root') as HTMLElement,
)

root.render(
    <StrictMode>
        <Exercise title={'Exercise 1: Multiplication Table'}>
            <ExerciseOne/>
        </Exercise>
        <Exercise title={'Exercise 2: Rater'} background={'#77EEEE'}>
            <ExerciseTwo/>
        </Exercise>
        <Exercise title={'Exercise 3: Progressbar'}>
            <ExerciseThree/>
        </Exercise>
        <Exercise title={'Exercise 4: Number grid'} background={'#99EEEE'}>
            <ExerciseFour/>
        </Exercise>
        <Exercise title={'Exercise 5: Comment card'}>
            <ExerciseFive/>
        </Exercise>
        <Exercise title={'Exercise 6: Calculator'}>
            <ExerciseSix/>
        </Exercise>
    </StrictMode>,
)