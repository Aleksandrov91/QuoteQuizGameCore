function checkOneChoiceAnswer(isCorrect, answer) {
    let isCorrectNum = isCorrect === 'True' ? 1 : 0;
    if (isCorrectNum === answer) {
        document.getElementById("success-notification").style.display = "block";
    } else {
        document.getElementById("fail-notification").style.display = "block";
    }

    setTimeout(showNextQuestion, 3000);
}

function checkMultipleChoicesAnswer(isCorrect) {
    if (isCorrect === 'True') {
        document.getElementById("success-notification").style.display = "block";
    } else {
        document.getElementById("fail-notification").style.display = "block";
    }

    setTimeout(showNextQuestion, 4000);
}

function showNextQuestion(correctAnswer) {
    $(".alert").alert('close');
    document.getElementById("nextQuestion").style.display = "block";
    document.getElementById("author").style.display = "block";
}