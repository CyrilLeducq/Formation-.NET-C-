import { useState } from "react";

const StateLessComponent = () => {
    const [monPrenom, setMonPrenom] = useState("Toto");
    const [age, setAge] = useState(20);
    
    const changerPrenom = () => {
        setMonPrenom("Titi")
    }

    const changerAge = () => {
        setAge(previousAge => previousAge + 1)
    }

    return ( 
        <>
            <h1>StateLessComponent</h1>
            <p>{monPrenom} - {age}</p>
            <button onClick={changerPrenom}>Changer prénom</button>
            <button onClick={changerAge}>Changer age</button>
        </>
     );
}
 
export default StateLessComponent;