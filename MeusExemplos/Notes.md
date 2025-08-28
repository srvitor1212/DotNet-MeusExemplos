

# Análogia com fazer um café da manhã ASSÍNCRONO

O cozinheiro(thread) experiente pode fazer um café de forma assíncrona:
	- aquecendo a frigideira para os ovos e; 
	- em seguida, começa a preparar as batatas fritas; 
	- coloca o pão na torradeira e começa a preparar os ovos;
	- etc.
A cada etapa do processo, você inicia uma tarefa e, em seguida, passa para outras tarefas que estejam prontas para sua atenção.

# Análogia com fazer um café da manhã SINCRONO

Para um algoritmo paralelo, você precisa de várias pessoas cozinhando (ou várias threads). 
Uma pessoa cozinha os ovos, outra cozinha as batatas fritas e assim por diante. Cada pessoa se concentra em sua tarefa específica. 
Cada pessoa que cozinha (ou cada thread) fica bloqueada, aguardando sincronizadamente a conclusão da tarefa atual: batatas fritas prontas 
para virar, pão pronto para assar na torradeira e assim por diante.

