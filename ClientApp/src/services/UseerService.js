export async function getAllUseers() {

    const response = await fetch('/api/useers');
    return await response.json();
}

export async function createUseer(data) {
    const response = await fetch(`/api/useer`, {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(data)
      })
    return await response.json();
}