$(document).ready(function(){
    $('#on').fadeIn(function(){
        $("#submenu1").hide();
        $('#submenu2').hide();
        $('#submenu3').hide();
    });
    
    $('#on').click(function(){
        $("#submenu1").show();
        $('#submenu2').hide();
        $('#submenu3').hide();
    });  
    
   
    $('#on1').click(function(){
        $("#submenu2").show();
        $('#submenu1').hide();
        $('#submenu3').hide();
    });

    
    $('#on2').click(function(){
        $('#submenu3').show();
        $('#submenu2').hide();
        $('#submenu1').hide();
    });
});
