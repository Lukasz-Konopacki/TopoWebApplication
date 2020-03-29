var photo = ["img/Sokoliki.jpg", "img/szczytnik.jpg", "img/jura.jpg", "img/tatry.jpg"];
var imgDesc = ["Góry Sokole","Okolice Szczytnika","Jura","Tatry"];

la = document.getElementById("left-arrow");
ra = document.getElementById("right-arrow");

lr = document.getElementById("left-region");
mr = document.getElementById("middle-region");
rr = document.getElementById("right-region");


la.addEventListener("click", switchleft);
ra.addEventListener("click", switchright);

var j = 1;

function switchleft()
{
    j++;
    var i=j-1;
    var k=j+1;

    if(k == photo.length)
    {
        k = 0;
    }
    if(k == photo.length+1)
    {
        k = 1;
    }
    if(j  == photo.length)
    {
        j=0;
    }

    lr.firstElementChild.firstElementChild.src = photo[i];
    mr.firstElementChild.firstElementChild.src = photo[j];
    rr.firstElementChild.firstElementChild.src = photo[k];

    lr.firstElementChild.getElementsByTagName("figcaption")[0].innerText = imgDesc[i];
    mr.firstElementChild.getElementsByTagName("figcaption")[0].innerText = imgDesc[j];
    rr.firstElementChild.getElementsByTagName("figcaption")[0].innerText = imgDesc[k];
}

function switchright()
{
    j--;
    var i=j-1;
    var k=j+1;

    if(i == -1)
    {
        i = photo.length-1;
    }
    if(i == -2)
    {
        i = photo.length-2;
    }
    if(j < 0)
    {
        j=photo.length-1;
    }


    lr.firstElementChild.firstElementChild.src = photo[i];
    mr.firstElementChild.firstElementChild.src = photo[j];
    rr.firstElementChild.firstElementChild.src = photo[k];
    
    lr.firstElementChild.getElementsByTagName("figcaption")[0].innerText = imgDesc[i];
    mr.firstElementChild.getElementsByTagName("figcaption")[0].innerText = imgDesc[j];
    rr.firstElementChild.getElementsByTagName("figcaption")[0].innerText = imgDesc[k];
}