
let likes = document.getElementsByClassName('numLikes') //array
let likeButton = document.getElementsByClassName('like') //array
// console.log(likes)
// console.log(likeButton)
function increaseCount(element){
    for(let i = 0; i < likeButton.length; i++){
        if(element == likeButton[i]){
            let count = likes[i].innerText
            count++
            likes[i].textContent = count
        }
    }
}