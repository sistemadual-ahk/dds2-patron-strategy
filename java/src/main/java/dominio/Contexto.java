package dominio;

import dominio.estrategias.Estrategia;

public class Contexto {
    private Estrategia estrategia;

    public void actuar(){
        this.estrategia.ejecutar();
    }

    public void cambiarEstrategia(Estrategia estrategia){
        this.estrategia = estrategia;
    }
}