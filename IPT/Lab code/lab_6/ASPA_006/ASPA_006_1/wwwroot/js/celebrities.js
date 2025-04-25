let celebrities = [];
fetch("/api/celebrities").then(reponse => reponse.json()).then(
    data => {
        celebrities = data;
        const grid = document.getElementById('photoGrid');
        data.forEach(c => {
            const img = document.createElement('img');
            img.src = `/api/celebrities/photo/${c.reqPhotoPath}`;
            img.id = c.id;
            img.title = "Click to get more info";
            img.onload = function () { LoadPhoto(this,200,0)}
            img.onclick = () => showInfo(c.id);
            grid.appendChild(img) 
        })
    }
).catch(err=>console.error("Failed to fetch",err))



function LoadPhoto(obj,height,width){
    let ratio = obj.naturalWidth / obj.naturalHeight;

    if (height != 0 && width == 0) {
        obj.width = Math.round(ratio * height);
    }
    if (height == 0 && width != 0) {
        obj.height = Math.round(width / ratio);
    }
}

function showInfo(id) {
    const celeb = celebrities.find(c => c.id === id);

    if (!celeb) {
        console.error(`Failed to get celebrity by id ${id}`);
        return;
    }

    fetch(`/api/lifeEvents/Celebrities/${id}`).then(
        response => response.json()
    ).then(data => {
        if (!data) {
            throw new Error("No data for this celebrity")
        }
        const container = document.getElementById('celebrityInfo');
        const Errtext = document.createElement('p');
        if (data.length === 0) {
            Errtext.innerHTML = "No data for this celebrity";
            container.appendChild(text);
        }
        data.forEach(l => {
            const text = document.createElement('p');
            console.log(l);
            console.log(celeb);
            text.innerHTML += `Full Name: ${celeb.fullName}\n`;
            text.innerHTML += `Event's date: ${l.date.split('T')[0]}\n`;
            text.innerHTML+=`What happened: ${l.description}\n`
            container.appendChild(text);
        })
    }).catch(err => console.error(`No data for celebrity with id ${id}`));

}