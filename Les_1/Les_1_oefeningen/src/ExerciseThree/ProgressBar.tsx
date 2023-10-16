import {FunctionComponent} from 'react'





const Label: FunctionComponent<ProgressBarProps> = ({percentage, color}) => {
    return (
        <text x="180" y="25" fill={color} className={'label'}>
            {percentage} %
        </text>
    )
}



const Bar: FunctionComponent<ProgressBarProps> = ({percentage, color}) => {

    const d = `M20 55 l${(percentage / 100) * 360} 0`
    return (
        <g fill={'none'} stroke={color} strokeWidth="25">
            <path strokeLinecap="round" d={d}/>
        </g>
    )


}

interface ProgressBarProps {
    percentage: number
    color: string
}

const ProgressBar: FunctionComponent<ProgressBarProps> = ({percentage, color}) => {
    return (
        <svg height="80" width="400">
            <Bar percentage={100} color="lightgrey"/>
            <Bar percentage={percentage} color={color}/>
            <Label percentage={percentage} color={color}/>
        </svg>
    )
}

export default ProgressBar
