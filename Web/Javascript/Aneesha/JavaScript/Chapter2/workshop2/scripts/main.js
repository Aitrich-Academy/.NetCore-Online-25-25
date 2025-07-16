function showForm(buttonVal)
{
    

    if(buttonVal=="myButton1")
    {
     var id=document.getElementById('myTextBox');
    
    var skillButton=document.getElementById('myButton');

    id.style.display='block';
    skillButton.style.display='block';
    }

    else if(buttonVal=="myButton2")
    {

        var id=document.getElementById('eduTextBox');
        var eduButton=document.getElementById('eduButton');
        id.style.display='block';
        eduButton.style.display='block';
    }
        else if(buttonVal =="myButton3")
        {
            var id=document.getElementById('expTextBox');
            var expButton=document.getElementById('expButton');
            id.style.display='block';
            expButton.style.display='block';

        }
        else if(buttonVal =="aboutEditButton")
        {
            var id=document.getElementById('aboutTextBox');
            var aboutButton=document.getElementById('aboutButton');
            id.style.display='block';
            aboutButton.style.display='block';

        }

    
    
}

function add(text)
{
    if(text=="skill")
    {
    var data=document.getElementById('myTextBox').value;
    var textBox=document.getElementById('myTextBox');
    var listId=document.getElementById('skillList');
    var skills=[]
    skills.push(data);
    console.log(skills);
    for(i=0;i<skills.length;i++)
    {
        // Create a new list item
        var li = document.createElement('li');

         // Set the text content of the list item
            li.textContent = skills[i];

             // Append the list item to the list element
             listId.appendChild(li);
             textBox.value='';

    }
}

else if(text=="edu")
{

    var data=document.getElementById('eduTextBox').value;
    var textBox=document.getElementById('eduTextBox');
    var listId=document.getElementById('eduList');
    var edu=[]
    edu.push(data);
    console.log(edu);
    for(i=0;i<edu.length;i++)
    {
        // Create a new list item
        var li = document.createElement('li');

         // Set the text content of the list item
            li.textContent = edu[i];

             // Append the list item to the list element
             listId.appendChild(li);
             textBox.value='';

    }
}

else if(text=="exp"){
    var data = document.getElementById('expTextBox').value;
    var textBox = document.getElementById('expTextBox');
    var listId = document.getElementById('expList');
    var exp = [];
        exp.push(data);
        console.log(exp);
        for(i = 0; i < exp.length; i++) {
            var li = document.createElement('li');
            li.textContent = exp[i];
            listId.appendChild(li);
            textBox.value = '';

}

}

    else if(text=="about"){
        var data = document.getElementById('aboutTextBox').value;
        var textBox = document.getElementById('aboutTextBox');
        var listId = document.getElementById('aboutList');
        var about = [];
            about.push(data);
            console.log(about);
        for(i=0;i< about.length;i++){
            var li = document.createElement('li');
            li.textContent = about[i];
            listId.appendChild(li);
            textBox.value = '';
        }
        
    }

}