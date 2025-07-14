var candidateList= [
    { name: "Alen", image: "images/m1.png", qualification: "Qualification: MCA", experience: "Experience: 3 years", place: "Location: Bangalore" },
    { name: "Sarah", image: "images/m2.png", qualification: "Qualification: MSC", experience: "Experience: 2 years", place: "Location: Chennai" },
    { name: "Vivek", image: "images/m1.png", qualification: "Qualification: Btech", experience: "Experience: 5 years", place: "Location: Thiruvananthapuram" },
    { name: "Deepak", image: "images/m1.png", qualification: "Qualification: Btech", experience: "Experience: 2 years", place: "Location: Calicut" },
];


        const table= document.getElementById("applicantTable");
        for (let i = 0; i < candidateList.length; i+=2) {

            var td1= document.createElement("td");
            var td2= document.createElement("td");
            var tr=document.createElement("tr");
            

         td1.innerHTML = `<image src=${candidateList[i].image}>
                            <p>${candidateList[i].name}</p>
                            <p>Qualification: ${candidateList[i].qualification}</p>
                            <p>Experience: ${candidateList[i].experience}</p>
                            <p>Location: ${candidateList[i].place}</p>`;
         td2.innerHTML = `<image src=${candidateList[i+1].image}>
                            <p>${candidateList[i+1].name}</p>
                            <p>Qualification: ${candidateList[i+1].qualification}</p>
                            <p>Experience: ${candidateList[i+1].experience}</p>
                            <p>Location: ${candidateList[i+1].place}</p>`;
                             

        tr.appendChild(td1);
        tr.appendChild(td2);
        table.appendChild(tr);
        }