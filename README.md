# Learning Docker containers
## Basic Docker commands 

$ docker info

$ docker image ls 

$ docker ps

$ docker build <image-name> -t <tag-name>

$ docker run <tag-name>

### pushing image to dockerhub

$ docker tag <image> <newName>/<repoName>:<tagName>
  
$ docker tag firstcontainer uttycoder/firstcontainer

$ docker push uttycoder/firstcontainer
