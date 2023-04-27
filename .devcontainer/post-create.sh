## Install additional apt packages
sudo apt-get update \
    && sudo apt-get install -y dos2unix libsecret-1-0 xdg-utils \
    # libsecret-1-0: Required for Git Credential Manager
    && sudo apt clean -y \
    # 캐쉬 지운다
    && sudo rm -rf /var/lib/apt/lists/*
    # 그래도 남아있으면 또 지운다
    # 이유: 컨테이너는 가벼울 수록 좋다 (최대한 지움)

## Configure git
git config --global pull.rebase false
git config --global core.autocrlf input

## GitHub Copilot CLI ##
npm install -g @githubnext/github-copilot-cli
eval "$(github-copilot-cli alias -- "$0")"

## GitHub Copilot CLI ##
echo '
# Add GitHub Copilot CLI alias
alias ghcp='github-copilot-cli'
eval "$(github-copilot-cli alias -- "$0")"
' >> $HOME/.zshrc
echo '
# Add GitHub Copilot CLI alias
alias ghcp='github-copilot-cli'
eval "$(github-copilot-cli alias -- "$0")"
' >> $HOME/.bashrc

## AZURE BICEP CLI ##
az bicep install

## AZURE DEV CLI ##
curl -fsSL https://aka.ms/install-azd.sh | bash