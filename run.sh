#!/bin/bash

# Script para ejecutar la aplicación KSM_ULS en diferentes plataformas
# Autor: Generado automáticamente
# Fecha: $(date)

# Colores para mejorar la presentación
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

# Función para mostrar el menú principal
show_menu() {
    clear
    echo -e "${BLUE}=================================${NC}"
    echo -e "${BLUE}   Ejecutar KSM_ULS${NC}"
    echo -e "${BLUE}=================================${NC}"
    echo ""
    echo "Seleccione una plataforma:"
    echo ""
    echo "1) Windows"
    echo "2) Android"
    echo "3) iOS"
    echo "4) Mac Catalyst"
    echo "5) Salir"
    echo ""
    echo -n "Ingrese su opción (1-5): "
}

# Función para ejecutar en Windows
run_windows() {
    echo -e "${GREEN}Ejecutando en Windows...${NC}"
    echo ""
    dotnet run --framework net9.0-windows10.0.19041.0
}

# Función para ejecutar en Android
run_android() {
    echo -e "${GREEN}Ejecutando en Android...${NC}"
    echo ""
    dotnet run --framework net9.0-android
}

# Función para ejecutar en iOS
run_ios() {
    echo -e "${GREEN}Ejecutando en iOS...${NC}"
    echo ""
    dotnet run --framework net9.0-ios
}

# Función para ejecutar en Mac Catalyst
run_maccatalyst() {
    echo -e "${GREEN}Ejecutando en Mac Catalyst...${NC}"
    echo ""
    dotnet run --framework net9.0-maccatalyst
}

# Función para manejar errores
handle_error() {
    echo -e "${RED}Error: Opción no válida${NC}"
    echo "Presione Enter para continuar..."
    read
}

# Función principal
main() {
    while true; do
        show_menu
        read choice
        
        case $choice in
            1)
                run_windows
                echo ""
                echo "Presione Enter para continuar..."
                read
                ;;
            2)
                run_android
                echo ""
                echo "Presione Enter para continuar..."
                read
                ;;
            3)
                run_ios
                echo ""
                echo "Presione Enter para continuar..."
                read
                ;;
            4)
                run_maccatalyst
                echo ""
                echo "Presione Enter para continuar..."
                read
                ;;
            5)
                echo -e "${YELLOW}Saliendo...${NC}"
                exit 0
                ;;
            *)
                handle_error
                ;;
        esac
    done
}

# Verificar que estamos en el directorio correcto
if [ ! -f "KSM_ULS.csproj" ]; then
    echo -e "${RED}Error: No se encuentra el archivo KSM_ULS.csproj${NC}"
    echo "Por favor ejecute este script desde el directorio raíz del proyecto."
    exit 1
fi

# Ejecutar la función principal
main