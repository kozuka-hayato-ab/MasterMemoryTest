# 付録
本リポジトリは[Master Memory事始め(個人開発編)]()の付録です。

## 付録説明

## dotnetによる導入手順
dotnetによるGeneratorの導入手順を本READMEに示します。

### 手順
1. ***Homebrewの導入*** [Homebrewのサイト](https://brew.sh/index_ja)
2. ***$ brew install cask***  
	により、caskを使えるようにしてください
3. ***$ brew cask install dotnet-sdk***  
	dotnetコマンドのインストールを行ってください
4. ***$ dotnet***  
	コマンドが使えるか確認する
5. ***npmコマンドが使えるようにする***
	[MacにNode.jsをインストール](https://qiita.com/kyosuke5_20/items/c5f68fc9d89b84c0df09)  
	[Mac HomebrewでNode.jsをインストールする](https://qiita.com/miriwo/items/73d1546220f1c091a7d5)  
6. ***$ npm install -g tool***  
	npm経由でtoolを使えるようにします。  
7. ***$ dotnet new tool-manifest***   
8. ***.NetCore2系が欲しい***  
	インストールする。  
	[Download .NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)  
	大抵、macOS x64で大丈夫だと思います。  
9. ***$ dotnet tool install \-\-global MasterMemory.Generator \-\-version 2.0.5***  
	MasterMemoryジェネレータのインストールです。  
10. ***$ dotnet tool install \-\-global MessagePack.Generator \-\-version 2.1.152***  
	MessagePackジェネレータのインストールです。  
11. ***$ dotnet tool list***  
	MasterMemory.GeneratorとMessagePackが入っていることを確認してください  
12. ***$ echo 'export PATH="$PATH:$HOME/.dotnet/tools"' >> ~/.bashrc***  
	toolsにPATHを通します。  
13. ***$source ~/.bashrc***  
	ターミナルの再起動でも可です。  
