import {FunctionComponent} from 'react'
import {FontAwesomeIcon} from '@fortawesome/react-fontawesome'
import {faStar as starFull} from '@fortawesome/free-solid-svg-icons'
import {faStar as starOutline} from '@fortawesome/free-regular-svg-icons'



interface StarProps {
    full: boolean
}

const Star: FunctionComponent<StarProps> = ({full}) => {

    return <FontAwesomeIcon icon={full ? starFull : starOutline}/>
}

interface LabelProps {
    score: number
}

const Label: FunctionComponent<LabelProps> = ({score}) => {
    let lable = 'Excellent'
    if (score < 0.1) lable = 'Disaster'
    else if (score <= 0.3) lable ='Insufficient'
    else if (score <= 0.5) lable = 'Sufficient'
    else if (score <= 0.6) lable = 'Average'
    else if (score <= 0.8) lable = 'Good'
    else if (score <= 0.9) lable = 'Very good'

    return (
        <div>
            {lable}
        </div>
    )
}

interface RaterProps {
    rating: number
    max: number
}

const Rater: FunctionComponent<RaterProps> = ({rating, max}) => {
const stars = []
    for (let i = 1; i <= max; i++) {
        stars.push(<Star key ={i} full={i <= rating}/>)

    }
    return(
        <div className={'rater'}>
            <Label score={rating / max}/>
            {stars}
        </div>
    )
}

export default Rater
