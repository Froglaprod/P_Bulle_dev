# On constructie l'application dans le conteneur 
FROM mono:latest

# On installe les dépendances graphique sur le docker
RUN apt-get update && apt-get install -y \
    libgtk2.0-0

WORKDIR /opt/app 

# On copie les fichiers de l'app dans le conteneur 
COPY . /opt/app

# On lance l'appli au lancement du conteneur
CMD ["mono", "/opt/app/AttentionGet/bin/Debug/AttentionGet.exe"]
