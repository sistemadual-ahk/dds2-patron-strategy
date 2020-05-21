<?php
namespace dominio;

use dominio\estrategias\Estrategia;

class Contexto {
    /**
     * @var Estrategia
     */
    private $estrategia;

    public function actuar(){
        $this->estrategia->ejecutar();
    }

    public function cambiarEstrategia(Estrategia $estrategia){
        $this->estrategia = $estrategia;
    }
}