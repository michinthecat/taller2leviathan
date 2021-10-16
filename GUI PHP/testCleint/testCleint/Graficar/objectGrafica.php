<?php

function consultarListarPrecios()
        {           
           $soapClient = new SoapClient('http://localhost:8080/SWServidor/SWControlador?WSDL');  
           $objectGraficar = $soapClient->listarPreciosChidos()->return;       
                 
           return $objectGraficar;  
        }      
