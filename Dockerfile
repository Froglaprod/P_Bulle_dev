# Constuction de l'app dans le conteneur docker
FROM mono:latest
WORKDIR /opt/app 

# Copie des fichiers de l'application dans le conteneur 
COPY . /opt/app

# Exécution de l'application au lancement du conteneur
CMD ["mono", "opt/app/DinoGame/bin/Debug/DinoGame.exe"]