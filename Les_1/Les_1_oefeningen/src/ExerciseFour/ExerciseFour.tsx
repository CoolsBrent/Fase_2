import {FunctionComponent} from 'react'
import NumberGrid from './NumberGrid.tsx'

interface ExerciseFourProps {

}

const ExerciseFour: FunctionComponent<ExerciseFourProps> = () => {
    return (
        <div>
            <NumberGrid number={2}/>
            <NumberGrid number={3}/>
            <NumberGrid number={5}/>
        </div>
    )
}

export default ExerciseFour
