import React from 'react'

export const Useers = ({useers}) => {

    console.log('useers length:::', useers.length)
    if (useers.length === 0) return null

    const UseerRow = (useer,index) => {

        return(
              <tr key = {index} className={index%2 === 0?'odd':'even'}>
                  <td>{index + 1}</td>
                  <td>{useer.firstName}</td>
                  <td>{useer.lastName}</td>
                  <td>{useer.email}</td>
              </tr>
          )
    }

    const UseerTable = useers.map((useer,index) => UseerRow(useer,index))

    return(
        <div className="container">
            <h2>useers</h2>
            <table className="table table-bordered">
                <thead>
                <tr>
                    <th>useer Id</th>
                    <th>Firstname</th>
                    <th>Lastname</th>
                    <th>Email</th>
                </tr>
                </thead>
                <tbody>
                    {UseerTable}
                </tbody>
            </table>
        </div>
    )
}