import abc


class Estrategia(abc.ABC):

    @abc.abstractmethod
    def ejecutar(self):
        pass
