class Contexto(object):
    __estrategia = None

    def actuar(self):
        self.__estrategia.ejecutar()

    def cambiar_estrategia(self, estrategia):
        self.__estrategia = estrategia
