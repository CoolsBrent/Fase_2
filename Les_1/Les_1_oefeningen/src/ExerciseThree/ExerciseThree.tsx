import {FunctionComponent} from 'react'
import styled from 'styled-components'
import ProgressBar from './ProgressBar.tsx'

const ExerciseThreeDiv= styled.div`flex-direction: column;`

const ExerciseThree: FunctionComponent = () => {
    return (
        <ExerciseThreeDiv className={'exercise'}>
            <ProgressBar percentage={75} color={'#ce4b99'}/>
            <ProgressBar percentage={15} color={'#ce1b29'}/>
            <ProgressBar percentage={65} color={'#125b69'}/>
        </ExerciseThreeDiv>
    )
}

export default ExerciseThree
