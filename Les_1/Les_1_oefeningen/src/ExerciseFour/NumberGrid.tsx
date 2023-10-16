import {FunctionComponent} from 'react'
import '../assets/ExerciseFour.css'

interface NumberGridProps {
    number: number
}

const NumberGrid: FunctionComponent<NumberGridProps> = ({number}) => {

    const squares = []
    for (let i = 0; i < number; i++) {
        const row = []
        for (let j = 0; j < number; j++) {
            row.push(<button key={i * number + j + 1} className={'square'}>
                    {i * number + j + 1}
                </button>
            )
        }
squares.push(<div key={i} className={'grid-row'}>
    {row}
</div> )
    }

    return (
        <div className={'grid'}>
            {squares}
        </div>
    )
}

export default NumberGrid
