$(document).ready(function(){
	/*
		Desplegar Menu de Log in
	*/
	$("#login-display").on('click',function(){
		$(".Login-wrapper").slideToggle(700);
	});
    //Desplegar Bandas
	$(".band-option").hide().fadeIn(1000);
	//Animacion para Despliegue de Bandas

	$(".band-option").hover(function(){
		$(this).find(".cover-option").fadeIn();
	},function(){
		$(this).find(".cover-option").fadeOut();
	});
});