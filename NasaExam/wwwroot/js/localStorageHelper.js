function toggleFavorite(imageUrl) {
    let favorites = JSON.parse(localStorage.getItem("favorites")) || [];

    let index = favorites.indexOf(imageUrl);

    if (index === -1) {
        favorites.push(imageUrl);
    } else {
        favorites.splice(index, 1);
    }

    localStorage.setItem("favorites", JSON.stringify(favorites));
}

function isFavorite(imageUrl) {
    let favorites = JSON.parse(localStorage.getItem("favorites")) || [];
    return favorites.includes(imageUrl);
}

function getFavorites() {
    return JSON.parse(localStorage.getItem("favorites")) || [];
}
