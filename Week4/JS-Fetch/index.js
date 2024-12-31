const ownerForm = document.getElementById('owner-form');
ownerForm.addEventListener('submit', function(event)
{
    //Prevents the form from refreshing the page
    event.preventDefault();
    // console.log(event);

    //build req body outside for cleaner code
    const owner = {
        'name' : event.target.elements['name'].value,
        'address' : event.target.elements['address'].value
    }

    //fetch using promise format
    fetch('http://localhost:5200/api/Owner', {
        method: 'POST',
        body: JSON.stringify(owner),
        headers: {
            'Content-Type' : 'application/json'
        }
    })
    .then(res => {
        if(!res.ok)
        {
            console.log('Not ok', res);
        }
        return res.json();
    })
    .then(resJson => console.log(resJson))
    .catch(err => console.error('Problem', err))
});

async function getallpets()
{
    console.log('Get all pets!!!');

    //fetch using async/await format

    //get pets from Pet endpoint
    const res = await fetch('http://localhost:5200/api/Pet');
    const resJson = await res.json();

    console.log(resJson);

    //put our pets onto the screen
    const ul = document.createElement('ul');
    ul.id = 'pet-list';

    resJson.forEach((e) => {
        let li = document.createElement('li');
        li.innerText = JSON.stringify(e);
        ul.appendChild(li);
    })

    document.body.appendChild(ul);

}