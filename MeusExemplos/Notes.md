

# An�logia com fazer um caf� da manh� ASS�NCRONO

O cozinheiro(thread) experiente pode fazer um caf� de forma ass�ncrona:
	- aquecendo a frigideira para os ovos e; 
	- em seguida, come�a a preparar as batatas fritas; 
	- coloca o p�o na torradeira e come�a a preparar os ovos;
	- etc.
A cada etapa do processo, voc� inicia uma tarefa e, em seguida, passa para outras tarefas que estejam prontas para sua aten��o.

# An�logia com fazer um caf� da manh� SINCRONO

Para um algoritmo paralelo, voc� precisa de v�rias pessoas cozinhando (ou v�rias threads). 
Uma pessoa cozinha os ovos, outra cozinha as batatas fritas e assim por diante. Cada pessoa se concentra em sua tarefa espec�fica. 
Cada pessoa que cozinha (ou cada thread) fica bloqueada, aguardando sincronizadamente a conclus�o da tarefa atual: batatas fritas prontas 
para virar, p�o pronto para assar na torradeira e assim por diante.

