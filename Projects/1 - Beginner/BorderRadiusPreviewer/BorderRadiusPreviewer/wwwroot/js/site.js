function TopLeft() {
    var topLeft = document.getElementById('top-left');

    if (topLeft.value > 0) {
        document.getElementById('float-child-right').style.borderTopLeftRadius = topLeft.value + "px";
        document.getElementById('topLeft').innerHTML = topLeft.value + "px;";
    }
    else {
        document.getElementById('float-child-right').style.borderTopLeftRadius = "0px";
        document.getElementById('topLeft').innerHTML = "0px;";
    }
}

function TopRight() {
    var topRight = document.getElementById('top-right');
    if (topRight.value > 0) {
        document.getElementById('float-child-right').style.borderTopRightRadius = topRight.value + "px";
        document.getElementById('topRight').innerHTML = topRight.value + "px;";
    }
    else {
        document.getElementById('float-child-right').style.borderTopRightRadius = "0px";
        document.getElementById('topRight').innerHTML = "0px;";
    }
}

function BottomLeft() {
    var bottomLeft = document.getElementById('bottom-left');
    if (bottomLeft.value > 0) {
        document.getElementById('float-child-right').style.borderBottomLeftRadius = bottomLeft.value + "px";
        document.getElementById('bottomLeft').innerHTML = bottomLeft.value + "px;";
    }
    else {
        document.getElementById('float-child-right').style.borderBottomLeftRadius = "0px";
        document.getElementById('bottomLeft').innerHTML = "0px;";
    }
}

function BottomRight() {
    var bottomRight = document.getElementById('bottom-right');
    if (bottomRight.value > 0) {
        document.getElementById('float-child-right').style.borderBottomRightRadius = bottomRight.value + "px";
        document.getElementById('bottomRight').innerHTML = bottomRight.value + "px;";
    }
    else {
        document.getElementById('float-child-right').style.borderBottomRightRadius = "0px";
        document.getElementById('bottomRight').innerHTML = "0px;";
    }
}


function CopyToClipboard() {
    var topleft = document.getElementById('topLeft').innerHTML;
    var topright = document.getElementById('topRight').innerHTML;
    var bottomleft = document.getElementById('bottomLeft').innerHTML;
    var bottomright = document.getElementById('bottomRight').innerHTML;

    var copyText = topleft + " " + topright + " " + bottomleft + " " + bottomright;

    navigator.clipboard.writeText(copyText);

    alert("Copied Code!");
}