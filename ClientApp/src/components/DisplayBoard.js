import React from 'react'

export const DisplayBoard = ({numberOfUseers, getAllUseers}) => {

    
    return(
        <div style={{backgroundColor:'green'}} className="display-board">
            <h4 style={{color: 'white'}}>useers Created</h4>
            <div className="number">
            {numberOfUseers}
            </div>
            <div className="btn">
                <button type="button" onClick={(e) => getAllUseers()} className="btn btn-warning">Get all useers</button>
            </div>
        </div>
    )
}