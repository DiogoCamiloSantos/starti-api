

IMAGE_NAME="starti-api"  
PORT=5006

function exibir_ajuda {
    echo "Uso: ./deploy.sh [-n|--image-name <nome_imagem>] [-p|--port <porta>]"
    echo "  -n, --image-name    Nome da imagem Docker a ser construída e executada"
    echo "  -p, --port          Porta que o contêiner Docker irá expor"
    exit 1
}

while [[ $# -gt 0 ]]; do
    key="$1"
    case $key in
        -n|--image-name)
        IMAGE_NAME="$2"
        shift 
        shift 
        ;;
        -p|--port)
        PORT="$2"
        shift 
        shift 
        ;;
        -h|--help)
        exibir_ajuda
        ;;
        *)    
        echo "Opção inválida: $1"
        exibir_ajuda
        ;;
    esac
done


docker rm -f ${IMAGE_NAME}_container


docker build -t ${IMAGE_NAME} .


docker run -d -p ${PORT}:80 -e ASPNETCORE_URLS=http://+:80 --name ${IMAGE_NAME}_container ${IMAGE_NAME}
