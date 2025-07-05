var jobList = [
    {jobTitle:"Social Media Assistant",location:"online",date:"16-06-23",Time:"10 am"},
    {jobTitle:"Brand Designer",location:"offline",date:"16-06-23",Time:"12 pm"},
    {jobTitle:"Customer Manager",location:"online",date:"20-06-23",Time:"12 pm"}

    
]

function loadData()
{
    var jobTitle1 = document.getElementById("jobTitle1");
    var jobTitle2 = document.getElementById("jobTitle2");
    var jobTitle3 = document.getElementById("jobTitle3");
    

    var location1 = document.getElementById("location1");
    var location2 = document.getElementById("location2");
    var location3 = document.getElementById("location3");

    
    var date1 = document.getElementById("date1");
    var date2 = document.getElementById("date2");
    var date3 = document.getElementById("date3");

    var Time1 = document.getElementById("time1");
    var Time2 = document.getElementById("time2");
    var Time3 = document.getElementById("time3");


    jobTitle1.innerHTML=jobList[0].jobTitle;
    location1.innerHTML ="Location:" +jobList[0].location;
    date1.innerHTML  = "date:" +jobList[0].date;
    Time1.innerHTML = "Time:"+jobList[0].Time;



    jobTitle2.innerHTML = jobList[1].jobTitle;
    location2.innerHTML ="Location:"+ jobList[1].location;
    date2.innerHTML = "date:"+ jobList[1].date;
    Time2.innerHTML = "Time" + jobList[1].Time;



    jobTitle3.innerHTML = jobList[2].jobTitle;
    location3.innerHTML = "location:"+jobList[2].location;
    date3.innerHTML = "date:"+jobList[2].date;
    Time3.innerHTML = "Time:"+jobList[2].Time;


}