const List =[{image:"pictures/images/Group 1126.png",jobRole:"Social Media Assistant",Location:"online",date:"16-06-23",Time:"10am"},
            {image:"pictures/images/Logo.png",jobRole:"Brand Designer",Location:"offline",date:"19-06-23",Time:"12.00pm"},
            {image:"pictures/images/Logo 27.png",jobRole:"Customer Manager",Location:"online",date:"20-06-23",Time:"12.00pm"},
          

];

const table = document.getElementById('studentList');
for(let a=0; a< List.length;a++){
var tr = document.createElement('tr');
var td = document.createElement('td');

// const imgHtml = List[a].image
//  ?`<img src="${List[a].image}" width = "60">`:'';

td.innerHTML = `<div class ="job-img"> <img src="${List[a].image}"> </p> <div class="job-info"> <p><b>${List[a].jobRole}</b></p> <p>Location:${(List[a].Location)}</p> <p>date:${(List[a].date)}</p> <p>Time:${(List[a].Time)}`
tr.appendChild(td);
table.appendChild(tr);

}

