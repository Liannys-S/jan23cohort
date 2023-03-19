$(document).ready(function(){
    $("#click").click(function(){
        alert("You just use .click function")
    })
    $("#hide").click(function(){
        $("#hide").hide(600)
    })
    $("#show").click(function(){
        $("#hide").show(600)
    }) 
    $("#toggle").click(function(){
        $("#hide").toggle(600)
    })
    $("#slideDown").click(function(){
        $("#slideUp").slideDown(600)
    })
    $("#slideUp").click(function(){
        $("#slideUp").slideUp(600)
    })
    
    $("#slideToggle").click(function(){
        $("#slideUp").slideToggle(600)
    })
    $("#fadeIn").click(function(){
        $("#fadeOut").fadeIn(500)
    })
    $("#fadeOut").click(function(){
        $("#fadeOut").fadeOut(500)
    })
    
    
})