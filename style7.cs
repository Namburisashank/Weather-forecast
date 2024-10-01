body {
    font-family: 'Times New Roman';
    background-color: #f0f8ff;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
    background-image: url("https://img.freepik.com/premium-vector/sky-clouds-design-with-flat-cartoon-poster-flyers-postcards-web-banners_771576-58.jpg");
    background-repeat: no-repeat;
    background-size: 1500px 800px;
    }
    
    h1 {
    font-weight: bold;
    margin-bottom: 10px;
    animation: rainbow 2s infinite;
    }
    
    @keyframes rainbow {
    0% {
    color: #ff0000;
    }
    20% {
    color: #ffa500;
    }
    40% {
    color: #ffff00;
    }
    60% {
    color: #008000;
    }
    80% {
    color: #0000ff;
    }
    100% {
    color: #4b0082;
    }
    }
    
    .container {
    text-align: center;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
    background-color: rgba(255, 255, 255, 0.5);
    width: 400px;
    height: 450px;
    }
    
    .flip-card {
    perspective: 1000px;
    transition: transform 0.6s;
    width: 70%;
    height: 170px;
    position: relative;
    margin: 20px auto;
    background-color: rgb(248, 222, 180);
    border-radius: 10px;
    }
    
    .flip-card-front, .flip-card-back {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    backface-visibility: hidden;
    transition: transform 0.6s;
    padding: 20px;
    border-radius: 10px;
    }
    
    .flip-card-front {
    z-index: 2;
    background-color: rgb(104, 106, 240);
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    border: 2px dashed #ccc;
    }
    
    .flip-card-front img {
    width: 100px;
    height: 100px;
    }
    
    .flip-card-back {
    background-color: #e66a6a;
    transform: rotateY(180deg);
    z-index: 1;
    }
    
    .flip-card.flipped .flip-card-front {
    transform: rotateY(180deg);
    }
    
    .flip-card.flipped .flip-card-back {
    transform: rotateY(0deg);
    }
    
    input, button {
    margin: 10px 0;
    padding: 10px;
    border-radius: 5px;
    border: 1px solid #ccc;
    font-size: 16px;
    }
    
    button {
    background-color: #007bff;
    color: white;
    cursor: pointer;
    }
    
    button:hover {
    background-color: #0056b3;
    }
    
    #cityInput {
    width: 90%;
    padding: 10px;
    font-size: 16px;
    }
    
    #weatherResult {
    padding: 20px;
    text-align: left;
    }
    
    #weatherResult h2 {
    margin-top: 0;
    }