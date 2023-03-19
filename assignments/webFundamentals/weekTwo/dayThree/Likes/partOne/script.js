var numLikes = document.querySelector(".numLikes")
let count = parseInt(numLikes.innerText)

function increaseCount(){
    count++
    numLikes.textContent = count
}